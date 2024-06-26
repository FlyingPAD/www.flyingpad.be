import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MoodDetailsComponent } from './mood-details.component';

describe('MoodDetailsComponent', () => {
  let component: MoodDetailsComponent;
  let fixture: ComponentFixture<MoodDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MoodDetailsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MoodDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
