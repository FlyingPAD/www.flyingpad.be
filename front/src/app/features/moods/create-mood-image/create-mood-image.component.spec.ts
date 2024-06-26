import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateMoodImageComponent } from './create-mood-image.component';

describe('CreateMoodImageComponent', () => {
  let component: CreateMoodImageComponent;
  let fixture: ComponentFixture<CreateMoodImageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CreateMoodImageComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CreateMoodImageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
