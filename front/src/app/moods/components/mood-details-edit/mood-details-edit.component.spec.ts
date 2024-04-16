import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MoodDetailsEditComponent } from './mood-details-edit.component';

describe('MoodDetailsEditComponent', () => {
  let component: MoodDetailsEditComponent;
  let fixture: ComponentFixture<MoodDetailsEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MoodDetailsEditComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MoodDetailsEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
